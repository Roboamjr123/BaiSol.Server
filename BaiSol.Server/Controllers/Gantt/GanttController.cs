﻿using BaseLibrary.DTO.Gantt;
using BaseLibrary.Services.Interfaces;
using DataLibrary.Data;
using DataLibrary.Models.Gantt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace BaiSol.Server.Controllers.Gantt
{
    [Route("api/[controller]")]
    [ApiController]
    public class GanttController(DataContext _dataContext, IGanttRepository _gantt) : ControllerBase
    {
        private class GanttResponse<T>
        {
            [JsonPropertyName("Items")]
            public T Items { get; set; }

            [JsonPropertyName("Count")]
            public int Count { get; set; }
        }

        private class Gantt
        {
            [JsonPropertyName("TaskId")]
            public int TaskId { get; set; }

            [JsonPropertyName("TaskName")]
            public string? TaskName { get; set; }

            [JsonPropertyName("PlannedStartDate")]
            public DateTime? PlannedStartDate { get; set; }

            [JsonPropertyName("PlannedEndDate")]
            public DateTime? PlannedEndDate { get; set; }

            [JsonPropertyName("ActualStartDate")]
            public DateTime? ActualStartDate { get; set; }

            [JsonPropertyName("ActualEndDate")]
            public DateTime? ActualEndDate { get; set; }

            [JsonPropertyName("Progress")]
            public int? Progress { get; set; }

            [JsonPropertyName("Duration")]
            public int? Duration { get; set; }

            [JsonPropertyName("Predecessor")]
            public string? Predecessor { get; set; }

            [JsonPropertyName("ParentId")]
            public int? ParentId { get; set; }
        }

        [HttpGet("{projId}")]
        public async Task<IActionResult> Get(string projId)
        {
            var tasks = await _dataContext.GanttData
                .Where(p => p.ProjId == projId)
                .ToListAsync();

            // Map GanttTask to Gantt DTO
            var mappedData = tasks.Select(task => new Gantt
            {
                TaskId = task.TaskId,
                TaskName = task.TaskName,
                PlannedStartDate = task.PlannedStartDate,
                PlannedEndDate = task.PlannedEndDate,
                ActualStartDate = task.ActualStartDate,
                ActualEndDate = task.ActualEndDate,
                Progress = task.Progress,
                Duration = task.Duration,
                Predecessor = task.Predecessor,
                ParentId = task.ParentId
            }).ToList();


            var response = new GanttResponse<List<GanttData>>
            {
                Items = tasks,
                Count = tasks.Count
            };

            // Return the list as a JSON response
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> FacilitatorTasks(string projId)
        {
            var tasks = await _gantt.FacilitatorTasks(projId);

            return Ok(tasks);
        }

        [HttpPost("{projId}")]
        public async Task<IActionResult> Post([FromBody] GanttData[] data, string projId)
        {
            // Set the projId for each Gantt object
            foreach (var gantt in data)
            {
                gantt.ProjId = projId; // Assign projId to each Gantt item
            }

            //// Get existing TaskIds from the database
            //var existingIds = _dataContext.GanttData
            //    .Where(g => data.Select(d => d.TaskId).Contains(g.TaskId))
            //    .Select(g => g.TaskId)
            //    .ToHashSet(); // Use HashSet for faster lookups

            //// Generate unique TaskIds if they already exist
            //foreach (var gantt in data)
            //{
            //    while (existingIds.Contains(gantt.TaskId))
            //    {
            //        gantt.TaskId++; // Increment to find a unique TaskId
            //    }
            //    existingIds.Add(gantt.TaskId); // Add the new TaskId to the set
            //}


            await _dataContext.GanttData.AddRangeAsync(data);
            await _dataContext.SaveChangesAsync();
            return Ok(data);
        }

        [HttpPut("{projId}")]
        public async Task<IActionResult> Put([FromBody] GanttData[] value, string projId)
        {
            if (value == null || value.Length == 0)
            {
                return BadRequest("Data is null or empty.");
            }

            foreach (var updatedData in value)
            {
                var existingData = await _dataContext.GanttData
                    .FirstOrDefaultAsync(i => i.TaskId == updatedData.TaskId && i.ProjId == projId);

                if (existingData == null)
                {
                    return NotFound($"GanttData with TaskId {updatedData.TaskId} not found.");
                }

                // Update properties
                existingData.TaskName = updatedData.TaskName;
                existingData.PlannedStartDate = updatedData.PlannedStartDate;
                existingData.PlannedEndDate = updatedData.PlannedEndDate;
                existingData.ActualStartDate = updatedData.ActualStartDate;
                existingData.ActualEndDate = updatedData.ActualEndDate;
                existingData.Progress = updatedData.Progress;
                existingData.Duration = updatedData.Duration;
                existingData.Predecessor = updatedData.Predecessor;
                existingData.ParentId = updatedData.ParentId;
            }

            await _dataContext.SaveChangesAsync();
            return Ok(value);
        }

        [HttpDelete("{projId}/{id:int}")]
        public async Task<IActionResult> Delete(int id, string projId)
        {
            // Find the existing record by TaskId
            var existingData = await _dataContext.GanttData
                    .FirstOrDefaultAsync(i => i.TaskId == id && i.ProjId == projId);

            if (existingData == null)
            {
                // Return a NotFound result if the record does not exist
                return NotFound($"GanttData with TaskId {id} not found.");
            }

            // Remove the existing record
            _dataContext.GanttData.Remove(existingData);

            // Save changes to the database
            await _dataContext.SaveChangesAsync();

            return Ok(id);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> FinishTask(UploadTaskDTO finishTask)
        {
            var (isSuccess, Message) = await _gantt.HandleTask(finishTask, false);
            if (!isSuccess)
                return BadRequest(Message);

            return Ok(Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> StartTask(UploadTaskDTO finishTask)
        {
            var (isSuccess, Message) = await _gantt.HandleTask(finishTask, true);
            if (!isSuccess)
                return BadRequest(Message);

            return Ok(Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> TaskById(int id)
        {
            var task = await _gantt.TaskById(id);

            return Ok(task);
        }
    }
}
