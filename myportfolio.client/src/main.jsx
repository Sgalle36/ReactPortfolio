import React, { Suspense, lazy } from 'react'
import ReactDOM from 'react-dom/client'
// filename app.js
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";
import Navbar from './components/Navbar/Navbar'
import Home from './pages/index'
import Projects from './pages/projects'
import Hobbies from './pages/hobbies'
import AboutMe from './pages/aboutme'
import './index.css'
import 'material-symbols';


ReactDOM.createRoot(document.getElementById('root')).render(
    <>
        <Navbar />
        <Home />
        <Projects />
        <Hobbies />
        <AboutMe />
    </>
)
