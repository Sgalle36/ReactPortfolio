import React from 'react'
import './Hero.css'
import profile from '/src/assets/images/profile.jpg'

function Hero() {
    return <>
        <section className="hero-container">
            <div className="hero-content">
                <h2>Developing innovative solutions to complex problems</h2>
                <p>Determined and driven software engineer | Solving complex
                    real-world problems one line at a time</p>
            </div>

            <div className="hero-img">
                <div>
                    <div className="tech-icon">
                        <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" />
                    </div>
                    <img src={profile} />
                </div>

                <div>
                    <div className="tech-icon">
                        <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/react/react-original.svg" />
                    </div>
                    <div className="tech-icon">
                        <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dotnetcore/dotnetcore-original.svg" />
                    </div>
                    <div className="tech-icon">
                        <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/php/php-original.svg" />
                    </div>
                    <div className="tech-icon">
                        <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/java/java-original.svg" />
                    </div>
                    <div className="tech-icon">
                        <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/javascript/javascript-original.svg" />
                    </div>
                </div>
            </div>
        </section>
    </>;
}

export default Hero;