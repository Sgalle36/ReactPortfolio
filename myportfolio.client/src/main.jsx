import React, { Suspense, lazy } from 'react'
import ReactDOM from 'react-dom/client'
// filename app.js
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";
import Navbar from './layouts/Navbar'
import Home from './pages/index'
import Projects from './pages/projects'
import Hobbies from './pages/hobbies'
import AboutMe from './pages/aboutme'
import './index.css'


ReactDOM.createRoot(document.getElementById('nav')).render(
    <React.StrictMode>
            <Navbar />
    </React.StrictMode>,
)

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
        <Suspense>
            <Home />
            <Projects />
            <Hobbies />
            <AboutMe />
        </Suspense>
  </React.StrictMode>,
)
