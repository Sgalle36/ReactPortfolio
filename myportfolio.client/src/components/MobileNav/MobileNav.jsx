import React from 'react'
import PropTypes from 'prop-types'
import './MobileNav.css'

function MobileNav({ isOpen, toggleMenu }) {
  return (
      <>
          <div
              className={`mobile-menu ${isOpen ? "active" : ""}`}
              onClick={toggleMenu}>

              <div className="mobile-menu-container">
                <p className="logo">Stephanie Gallegos</p>
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
                    <button className="btn-primary">Contact Me</button>
                  </ul>
              </div>
          </div>
      </>
  );
}

export default MobileNav;

MobileNav.propTypes = {
    isOpen: PropTypes.bool,
    toggleMenu: PropTypes.func,
}
