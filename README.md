# HRTool
 
 Human Reources Admin Tool to visualize the size of departments over time to help manage facilities, supplies, resources, etc.
 The graph shows employees joined per month. Clicking on the graph verticies shows the list of users joined that month
 Changing departments or a date range, filters the graph of automatically.

# Tools used and why

 #### Chart.js - for handing the chart visualization
 #### Flatpickr - for the range calender
 #### Moment.js - to assist with comparing dates and formatting
 #### Bootstrap/jQuery - to help format and build the page out quickly
 #### Azure hosted SQL Server - to give me a chance to learn about it, no need to worry about sending database dll's 
 #### C# MVC - a requirement on the project

# Thoughts
 It was tough drawing a line in the sand for additional features because it could easily grow. Though I could tell it was getting more complex so I kept it fairly slim.
 If I were to add one additional feature later, it would be displaying a photo with that individuals work anniversary (for the current month and upcoming month in different sections)


# Future Enhancements
 Improve the database integration. Reading into the objects is a bit messy since it was the last thing I was hooking up.
 Componentize the page with a framework. The JS is currently tightly coupled to the graph so breaking the HTML/JS apart from another wasn't as simple as I had hoped. 
 Cache the data based on an expiration timestamp because it will rarely change
 Error handling. It's currently quite rudamentory and I rely on the data being exactly the right format
 Unit testing the queries
 
![Photo of App](https://lh3.googleusercontent.com/pw/ACtC-3fw_a4v27s5qgYWr_ot9iiL36oe8MijmYOeMwMhvCQNvZj5E9BklvVy5RtSwaP8q1QafxkPaz7OeObJ0Hn_iQ7Zwlt_moqC6W5a_NB55mRZM1riVOV4dI9DOiTeyY_NCr5L5Zg5QrfUzvcuwArdNcuDmA=w1491-h859-no?authuser=0)

