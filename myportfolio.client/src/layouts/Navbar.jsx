import './Navbar.css'
import NavLink from './../components/nav/NavLink.jsx'

export default function Navbar() {
    return <nav>
        <a>Stephanie Gallegos</a>
        <ul>
            <NavLink text={ "Home" } url={ "#home" }></NavLink>
            <NavLink text={ "Projects" } url={ "#projects" }></NavLink>
            <NavLink text={ "About Me" } url={ "#about-me" }></NavLink>
            <NavLink text={ "Hobbies" } url={ "#hobbies" }></NavLink>
        </ul>
    </nav>
}