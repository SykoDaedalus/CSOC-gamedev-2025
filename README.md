# CSOC-GAMEDEV-2025

<p align="center">
  <picture align="center">
    <source media="(prefers-color-scheme: dark)" srcset="[https://i.pinimg.com/originals/f3/e6/4a/f3e64a3c37c4fcaeef74cfef83ff9847.gif](https://i.pinimg.com/originals/ab/76/17/ab761745f01df090ec38b827dd65e58a.gif)">
    <img align="center" alt="Sample GIF" src="https://i.pinimg.com/originals/ab/76/17/ab761745f01df090ec38b827dd65e58a.gif" width="560">
  </picture>
</p>

<p align="center">
  <strong>
  <em>COPS SUMMER OF CODE flagship program of COPS IIT-BHU to make you familiar with open-source and teach you your favourite skills.
    This repo contains resources for GAMEDEV track
  </strong>
</p>



## Goals

By the end, you should be proficient enough to create something awesome!

<table>
<tr>
  <td style="vertical-align: top; width: 30%;">
    <pre>

```c#
void Start()
{
    rb = GetComponent<Rigidbody2D>();
}

void Update()
{
    transform.Translate(Vector2.right * speed * Time.deltaTime);

    isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1f, groundLayer);

    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
```

    
  </td>
  <td style="text-align: center; width: 100%;">
    <img src="https://i.pinimg.com/originals/14/b9/9e/14b99e109b3a1f14dfeaf54bb83f55f8.gif" width="100%">
  </td>
</tr>
</table>


 ### Git and GitHub

Git is a distributed version control system that allows developers to track changes in their code and collaborate with others. GitHub is a web-based platform that hosts Git repositories and provides additional collaboration features.

**Resources:**
- [Git & GitHub Tutorial](https://youtu.be/q8EevlEpQ2A?si=zMpFSrSSQ8kIM5bI) - Complete beginner One shot
- [Git Cheat Sheet](https://education.github.com/git-cheat-sheet-education.pdf)
# Unity Beginner Setup Guide

## Prerequisites

Before you begin, ensure you're familiar with the following:

- **Unity Editor Setup**
- **Basic Programming Concepts**: variables, `if-else`, `for` loops, etc.

---

## Task Overview

This guide will help you:

1. Set up Unity on your system
2. Configure Visual Studio Code for Unity development
3. Brush up on essential C# programming concepts

---

## Setup Instructions
  
### 1. Check System Requirements

Your system must meet Unity's minimum hardware and software requirements.

- [Unity System Requirements](https://docs.unity3d.com/2023.1/Documentation/Manual/system-requirements.html)

### 2. Install Unity Hub

Unity Hub is a tool for managing Unity installations, projects, and licenses.

- [Download Unity Hub](https://unity.com/download)

Once installed, create a Unity account if prompted.

### 3. Install Unity Editor

Download the latest **Unity Editor (LTS version)** through Unity Hub. Use the default installation settings.

> You may **uncheck Visual Studio Community** during installation—we'll use **Visual Studio Code** instead.

### 4. Video Guides (Optional but Recommended)

- Unity Installation Walkthrough: *[Watch here](https://www.youtube.com/watch?v=your-link)*
- Setting up VS Code for Unity: *[Watch here](https://www.youtube.com/watch?v=your-link)*

---

## C# Programming Essentials

### For Beginners

If you've taken a CS101 course, you likely already know the basics. However, C# has a Java-like syntax that can feel verbose.

To build fluency, try solving basic problems in C#. It helps make the syntax second nature.

### If You're New to Programming

No worries! If you have experience in C, you'll find C# to be more structured and descriptive. The verbosity helps in understanding what the code does.

- [Brackeys C# Beginner Playlist](https://www.youtube.com/playlist?list=PLPV2KyIb3jR4u5jX8za5iU1v4I1tfi8mN)

---

# Week 0 Task

## Instructions

1. Fork the repository and clone it to your local machine.

2. Open the project in an editor of your choice.

3. Create a new branch for your work.

4. Inside the `Assets/Problems` folder, you will find four problems. Try to solve them.

5. To check your solutions, go to `Window → General → Test Runner`.

6. In Edit Mode, click **Run All** after writing your code to run the tests.
   <img align="center" alt="Test screen" src="https://i.pinimg.com/736x/3f/48/5e/3f485e5c2a60fda06516eef5f6902c13.jpg" width="560">

7. Once you're done, take a screenshot of your result.

8. Raise a pull request and attach the screenshot in the description.



