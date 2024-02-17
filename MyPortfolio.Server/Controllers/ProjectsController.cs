using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Server.Data;
using MyPortfolio.Server.Data.Models;
using MyPortfolio.Server.Interfaces;
using System.Diagnostics;

namespace MyPortfolio.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;
        private readonly UnitOfWork _unitOfWork;

        public ProjectsController(ILogger<ProjectsController> logger, UnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }


        [HttpGet(Name = "GetProjects")]
        public IEnumerable<Project> GetProjects()
        {
            List<Project> projects = _unitOfWork.Project.GetAll().ToList();
            return projects.ToArray();
        }
    }
}
