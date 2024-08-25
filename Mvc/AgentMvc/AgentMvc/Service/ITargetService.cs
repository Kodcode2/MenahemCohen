﻿using AgentMvc.Models;

namespace AgentMvc.Service
{
    public interface ITargetService
    {
        Task<List<TargetModel>> GetTargets();
    }
}
