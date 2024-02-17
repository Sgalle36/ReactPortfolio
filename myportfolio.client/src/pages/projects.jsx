import ProjectsGrid from "../components/projects/ProjectsGrid";
import Section from './../layouts/Section'

function projects() {
    return (
        <Section title={"Projects"} desc={"Projects I've worked on individually and in teams."} tag={"projects"} >
            <ProjectsGrid />
        </Section>);
}

export default projects;