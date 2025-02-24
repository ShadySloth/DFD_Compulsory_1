# Compolsory 1

Compolsory 1 for the subject, Database for Developers. 

There are two main off-branches, State and Change. They each contain database migrations for each method of doing migrations.

### Entities

In our student and course entity we made sure to use the column typeName annotation to ensure that the strings of the entities has a character limit.

In our enrollment entity we created a enum for the grades to ensure that only the correct values could be set as a grade.

## Change based migrations

### Migration 1

We edited the student entity to include a middle name attribute, 
we also made it have the annotation that limits the amount of characters as we have done on the other entities, 
but also made it nullable as not everyone have a middle name.

### Migration 2

We edited the student entity again to have it include a birthdate, 
we chose to make the attribute be a DateTime like we have done with the enrollment date.

### Migration 3

We added a new entity called instructor with the mentioned specifications and added it to the course entity as a foreign key.

### Migration 4

