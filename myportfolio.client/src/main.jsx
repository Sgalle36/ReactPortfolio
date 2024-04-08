import React, { Suspense, lazy } from 'react'
import ReactDOM from 'react-dom/client'
import Navbar from './components/Navbar/Navbar'
import Hero from './components/Hero/Hero'
import './index.css'
import 'material-symbols';


ReactDOM.createRoot(document.getElementById('root')).render(
    <>
        <Navbar />
        <div className="container">
            <Hero />
        </div>
    </>
)
