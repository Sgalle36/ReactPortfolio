import { useEffect, useState } from 'react';

function ProjectsGrid() {
    const [projects, setProjects] = useState();

    useEffect(() => { populateProjectsData(); }, []);

    const contents = projects === undefined
        ? <p>Error loading projects</p>
        :
        <div>
            <p>Projects</p>
            <div className="grid g-3">
            {projects.map(project =>
                <div className="card" key={project.id}>
                    <div className="card-body">
                        {project.name}
                    </div>
                </div>
                )}
            </div>
        </div>;

    return contents;

    async function populateProjectsData() {
        const response = await fetch("projects");
        const projects = await response.json();
        setProjects(projects);
    }
}



export default ProjectsGrid;