@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600&display=swap');

*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    text-decoration: none;
    border: none;
    outline: none;
    font-family: 'Poppins', sans-serif;
}

html{
    font-size: 62.5%;
}

body{
    width: 100%;
    height: 100vh;
    overflow-x: hidden;
    background-color: black;
    color: white;
}

header{
    margin-top: 20px;
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    padding: 1rem 9%;
    background-color: transparent;
    filter: drop-shadow(10px);
    display: flex;
    justify-content: space-between;
    align-items: center;
    z-index: 100;
}

.logo{
    font-size: 3rem;
    color: #b74b4b;
    font-weight: 800;
    cursor: pointer;
    transition: 0.5s ease;
}

.logo:hover{
    transform: scale(1.1);
}

nav a{
    font-size: 1.8rem;
    color: white;
    margin-left: 4rem;
    font-weight: 500;
    transition: 0.3s ease;
    border-bottom: 3px solid transparent;
}

nav a:hover,
nav a.active{
    color: #b74b4b;
    border-bottom: 3px solid #b74b4b;
}

@media(max-width:995px){
    nav{
        position: absolute;
        display: none;
        top: 0;
        right: 0;
        width: 40%;
        border-left: 3px solid #b74b4b;
        border-bottom: 3px solid #b74b4b;
        border-bottom-left-radius: 2rem;
        padding: 1rem solid;
        background-color: #161616;
        border-top: 0.1rem solid rgba(0,0,0,0.1);
    }

    nav.active{
        display: block;
    }

    nav a{
        display: block;
        font-size: 2rem;
        margin: 3rem 0;
    }

    nav a:hover,
    nav a.active{
        padding: 1rem;
        border-radius: 0.5rem;
        border-bottom: 0.5rem solid #b74b4b;
    }
}

section{
    min-height: 100vh;
    padding: 5rem 9% 5rem;
}

.home{
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 8rem;
    background-color: black;
}

.home .home-content h1{
    font-size: 6rem;
    font-weight: 700;
    line-height: 1.3;
}

span{
    color: #b74b4b;
}

.home-content h3{
    font-size: 4rem;
    margin-bottom: 1rem;
    font-weight: 700;
}

.home-content p{
    font-size: 1.6rem;
}

.home-img{
    border-radius: 50%;
}

.home-img img{
    position: relative;
    width: 32vw;
    border-radius: 50%;
    box-shadow: 0 0 25px solid #b74b4b;
    cursor: pointer;
    transition: 0.2s linear;
}

.home-img img:hover{
    font-size: 1.8rem;
    font-weight: 500;
}

.social-icons a{
    display: inline-flex;
    justify-content: center;
    align-items: center;
    width: 4rem;
    height: 4rem;
    background-color: transparent;
    border: 0.2rem solid #b74b4b;
    font-size: 2rem;
    border-radius: 50%;
    margin: 3rem 1.5rem 3rem 0;
    transition: 0.3s ease;
    color: #b74b4b;
}

.social-icons a:hover{
    color: black;
    transform: scale(1.3) translateY(-5px);
    background-color: #b74b4b;
    box-shadow: 0  0 25px #b74b4b;
}

.btn{
    display: inline-block;
    padding: 1rem 2.8rem;
    background-color: black;
    border-radius: 4rem;
    font-size: 1.6rem;
    color: #b74b4b;
    letter-spacing: 0.3rem;
    font-weight: 600;
    border: 2px solid #b74b4b;
    transition: 0.3s ease;
    cursor: pointer;
}

.btn:hover{
    transform: scale3d(1.03);
    background-color: #b74b4b;
    color: black;
    box-shadow: 0 0 25px #b74b4b;
}

.typing-text{
    font-size: 34px;
    font-weight: 600;
    min-width: 280px;
}

.typing-text span{
    position: relative;
}

.typing-text span::before{
    content: "software Developer";
    color: #b74b4b;
    animation: words 20s infinite;
}

.typing-text span::after{
    content: "";
    background-color: black;
    position: absolute;
    width: calc(100% + 8px);
    height: 100%;
    border-left: 3px solid black;
    right: -8;
    animation: cursor 0.6s infinite;
}

@keyframes cursor{
    to{
        border-left: 3px solid #b74b4b;
    }
}

@keyframes words{
    0%, 20%{
        content: "Software Engineer";
    }
    21%, 40%{
        content: "Cybersecurity Expert";
    }
    41%, 60%{
        content: "UI/UX Designer";
    }
    61%, 80%{
        content: "Programmer";
    }
    81%, 100%{
        content: "Scripter";
    }
}

@media (max-width: 1000px){
    .home{
        gap: 4rem;
    }
}

@media(max-width:995px){
    .home{
        flex-direction: column;
        margin: 5rem 4rem;
    }

    .home .home-content h3{
        font-size: 2.5rem;
    }

    .home-content h1{
        font-size: 5rem;
    }

    .home-img img{
        width: 70vw;
        margin-top: 4rem;
    }
}

/* Tools Section */
.tools {
    background: linear-gradient(to bottom, #250101, #0f0101); /* Very dark red mixed with black */
    color: #fff;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 10px 20px rgba(0, 0, 0, 0.7);
}

/* Section Title */
.tools .section-title {
    font-size: 2em;
    text-align: center;
    margin-bottom: 20px;
    color: #ffffff; /* Red text for the title */
}

/* Tool List */
.tools-list {
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
    gap: 20px;
    padding: 10px;
}

/* Tool Panel */
.tool {
    background: rgba(255, 255, 255, 0.1); /* Glass effect with transparency */
    border-radius: 10px;
    padding: 20px;
    width: 45%; /* Two tools per row */
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.5);
    backdrop-filter: blur(10px); /* Glass effect */
    transition: transform 0.3s ease;
}

.tool:hover {
    transform: scale(1.05); /* Slight zoom on hover */
}

/* Tool Image */
.tool-image {
    width: 50px;
    height: 50px;
    margin-bottom: 10px;
}

/* Tool Title */
.tool h4 {
    font-size: 1.2em;
    margin-bottom: 10px;
    color: #ff1a1a; /* Red text for tool titles */
}

/* Tool Description */
.tool p {
    font-size: 0.9em;
    color: #ccc;
    margin-bottom: 10px;
}

/* Links */
.tool a {
    font-size: 0.9em;
    color: #ff1a1a;
    text-decoration: none;
}

.tool a:hover {
    text-decoration: underline;
}
