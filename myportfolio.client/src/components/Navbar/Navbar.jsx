import React, { useState } from 'react'
import './Navbar.css'

import MobileNav from '../MobileNav/MobileNav';

export default function Navbar() {
    const [openMenu, setOpenMenu] = useState(false);

    const toggleMenu = () => {
        setOpenMenu(!openMenu);
    };

    return <>
        <MobileNav isOpen={openMenu} toggleMenu={toggleMenu} />
        <nav className="nav-wrapper">
            <div className="nav-content">
                <img className="logo" src="" />
                <p className="logo-text">Stephanie Gallegos</p>
                <ul>
                    <li>
                        <a className="nav-item" href="#home">Home</a>
                    </li>
                    <li>
                        <a className="nav-item" href="#projects">Projects</a>
                    </li>
                    <li>
                        <a className="nav-item" href="#about-me">Skills</a>
                    </li>
                    <li>
                        <a className="nav-item" href="#about-me">Experience</a>
                    </li>
                    <button type="button" className="btn-primary" onClick={() => { }}>
                        Contact Me
                    </button>
                </ul>
                <button className="nav-btn" onClick={toggleMenu}>
                    <span
                        className="material-symbols-outlined"
                        style={{ fontSize: "1.8rem" }}>
                        menu
                    </span>
                </button>

            </div>
        </nav>
    </>
}