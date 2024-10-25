﻿using PM.Domain.DTOs;
using PM.Persistence.Context;
using PM.Persistence.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Persistence.Services
{
    public class PlanInProjectServices : IPlanInProjectServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<PlanInProjectDTO> _repository;
        public PlanInProjectServices(ApplicationDbContext context, IRepository<PlanInProjectDTO> repository)
        {
            _context = context;
            _repository = repository;
        }
        public async Task<bool> AddAsync(PlanInProjectDTO planInProjectDTO)
        {
            return await _repository.AddAsync(planInProjectDTO);
        }
        public async Task<bool> UpdateAsync(string Id, PlanInProjectDTO planInProjectDTO)
        {
            return await _repository.UpdateAsync(Id, planInProjectDTO);
        }
        public async Task<bool> RemoveAsync(string Id)
        {
            return await _repository.DeleteAsync(Id);
        }
    }
}
