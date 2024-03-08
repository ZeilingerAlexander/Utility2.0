# Mysql Base Methods

## Basic Methods for Mysql because there is no easy to use auto generating for mysql implementation in c#
## Includes
### Opening/Closing Connection
### Getting all table names from DB
### Getting all column column Values for provided table and columnnames
### Getting the primary key column from a table
### Executing a custom query on the database (not recommended)
### Executing a "non" query on the database, same as custom query just without the returned datatable (not recommended)
### Getting the first Value of a column where the value equals a provided value (checks if they match), used for n-n connections
### Getting the value of a column based on the value of the base column
### Simple DB-Update for setting value by id
### Simple DB-Delete by id
### Simple DB-Delete by 2ids
### Adding a single entry with value to db
### Getting the last entry from a table (ordering by a given column)
### Adding Multiple Entries to DB from a dictionary
### Getting all entries from a Table