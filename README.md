<h1> Assignment in C# (.net framework) </h1>

<p>
A WPF application which can read a list of users from a file in the format: id;name;age;score

A sample file (TextFile1.txt) can be found inside the py folder, containing 1000 entries 

![Image of Application](https://i.imgur.com/DZT2A1Y.png)

<h2> Generating new users </h2>
<p>
Generating new users can be done running the generateUsers.py.
The generateUsers.py file can be run with an optional console line argument. </br>

    > py generateUsers.py 2000 

Will generate 2000 new users.

User ID's are all unique, but randomly assigned.
Names are generated by randomly combining danish first names with danish last names
