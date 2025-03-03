# Compolsory 1

Compolsory 1 for the subject, Database for Developers. 

There are two main off-branches, State and Change. They each contain database migrations for each method of doing migrations.

### Entities

In our student and course entity we made sure to use the column typeName annotation to ensure that the strings of the entities has a character limit.

In our enrollment entity we created a enum for the grades to ensure that only the correct values could be set as a grade.

## Change based migrations

### Migration 1 (Initial schema)

We created the entities for student, course and enrollment with their attributes. Since the id of the entities 
was just called id we didn't have to define their primary key as EF will automatically pick it as the primary key.
For the foreign keys we made use of the OnModelCreating method in our SchoolContext where we can add relations between tables.

### Migration 2

We edited the student entity to include a middle name attribute, 
we also made it have the annotation that limits the amount of characters as we have done on the other entities, 
but also made it nullable as not everyone have a middle name.

### Migration 3

We edited the student entity again to have it include a birthdate, 
we chose to make the attribute be a DateTime like we have done with the enrollment date.

### Migration 4

We added a new entity called instructor with the mentioned specifications and added it to the course entity as a foreign key.

### Migration 5

We decided on using a non-destructive approach to renaming the grade attribute.
We chose this way because it can prevent problems in the cade that would still use the old attribute.

### Migration 6

For this migration, we added the entity Department, in this we have added the Instructor entity as a foreign key.
Since Instructor is supposed to be a department head, we have made an attribute comment stating that, and this will be visible in the code so others can understand it.