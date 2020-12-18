using websiteclasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WebsiteData
{
    public interface IProjectData
    {
        IEnumerable<Projects> FilterProjects(string filterString);
    }

    public class InMemoryProjectData : IProjectData
    {
        readonly List<Projects> projects;

        public InMemoryProjectData()
        {
            projects = new List<Projects>() {
                new Projects {Id=0,ProjectName="Project 00",ProjectDesc="Multi Domain Mission Control Chat App",PType=ProjectType.Classified},
                new Projects {Id=1,ProjectName="Project 1",ProjectDesc="Mission Control Chat Analytics",PType=ProjectType.Classified},
                new Projects {Id=2,ProjectName="Project 2",ProjectDesc="Advanced Personnel Scheduling",PType=ProjectType.Classified},
                new Projects {Id=3,ProjectName="Project 3",ProjectDesc="Mission Control and Diagnostics App",PType=ProjectType.Classified},
                new Projects {Id=4,ProjectName="Project 4",ProjectDesc="Survey and Data Acquisition",PType=ProjectType.Classified}
            };
        }

        IEnumerable<Projects> IProjectData.FilterProjects(string filterString)
        {
            return from p in projects
                   let projectNameUpper = p.ProjectName.ToUpper()
                   let projectDescUpper = p.ProjectDesc.ToUpper()
                   where string.IsNullOrEmpty(filterString) || projectNameUpper.Contains(filterString.ToUpper()) || projectDescUpper.Contains(filterString.ToUpper())
                   orderby p.ProjectName
                   select p;
        }
    }
}
