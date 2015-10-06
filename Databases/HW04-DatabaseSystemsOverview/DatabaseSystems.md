
# Database Systems - Overview

--------------------


## 1. What database models do you know?

* Hierarchical
* Network
* Relational
* Object-oriented

## 2. Which are the main functions performed by a Relational Database Management System (RDBMS)?

* Creating, altering, deleting tables and their relationships.
* Adding, changing, deleting, searching and retrieving of data stored in the tables.
* SQL language support.
* Transaction management.

## 3. Define what is "table" in database terms.

Tables consist of data arranged in rows and columns, where all rows have the same structure, and columns have name and type. Database tables also have schemas, ordered sequence of column specifications.

## 4. Explain the difference between a primary and a foreign key.

Primary key is a column in a table that uniquely identifies its records, where a foreign key is an identifier column in a table that relates its records to another table's records.

## 5. Explain the different kinds of relationships between tables in relational databases.

* One-to-many -- The most popular relationship. One table record can relate to many records in another table. For instance, countries-towns tables relationship. A country from the countries table can relate to many towns from the towns table, but a town from the towns table can only relate to one country. 
* Many-to-many -- Many records from one table can relate to many records from another table. This is usually achieved through an intermediate relational table. Students-courses tables relationship is such as students can enrol for many courses, and courses can have many students enrolled.
* One-to-one -- One record from one table can relate to one and only one record from another table. This relationship is rarely used and usually models hierarchy and inheritance. Eg, people-fingerprints, a person can have only one set of unique fingerprints, and a set of fingerprints belongs to one and only one person.

## 6. When is a certain database schema normalized?

When a database contains redundant data, it can be normalized by organizing the columns and tables in such way, that no information is lost and unnecessary data duplication is minimized.

####    What are the advantages of normalized databases?

* Prevent update anomalies. Normalization minimizes logical inconsistencies when data is updated.
* Prevent insertion anomalies, where a record cannot be inserted in the database due to inconsistencies.
* Prevent deletion anomalies, where the deletion of one piece of data necessitates the deletion of other unrelated data.
* Allow extending of the database structure without affecting applications that already use it.
* Avoid query type bias, where a database serves some types of queries better than others.

## 7. What are database integrity constraints and when are they used?

Integrity constraints enforce rules which cannot be violated and ensure data integrity. 
* The primary key constraint takes care that every record can be uniquely identified. 
* The  unique key constraint ensures that values in any column are unique.
* The foreign key constraint ensures that values in a given column are valid keys to another table.
* Check constraints make sure a certain condition is met.

## 8. Point out the pros and cons of using indexes in a database.

Pros:
* Speed up search in a column.
* Improve query performance.
* Allow sorting.
* Guarantee uniqueness.

Cons:
* Slow down inserting and deleting records.
* Take up space.

## 9. What's the main purpose of the SQL language?

The SQL language is used for querying databases. It allows easy manipulation of big relational databases. SQL supports creating, altering and deleting tables and objects. Also, searching, retrieving, modifying and deleting table rows. It consisrs od Data Definition Language (DDL) for CREATE, ALTER and DROP commands, and Data Manipulation Language (DML) for SELECT, INSERT, UPDATE and DELETE commands.

## 10. What are transactions used for?

Transactions offer functionalities which ensure data consistency. They are used for critical records updates, where the order and concurrency of the execution of queries matters. Transactions are a sequence of database operations which are executed as a single unit -- they all succeed or they all fail.

#### Give an example.

Bank operations are a typical example of transactions where the operations on an account matter and any errors due to simultaneous execution are unacceptable.

## 11. What is a NoSQL database?

A NoSQL database does not rely on relations between tables and data consistency, and has no integrity constraints.

## 12. Explain the classical non-relational data models.

* Document model -- data is stored in a set document objects.
* Key-value model -- data is stored in a set of key-value pairs.
* Hierarchical key-value model -- data is stored in a hierarchical structure of key-value pairs.
* Wide-column model -- 
* Object model -- data is stored in a set of OOP objects.

## 13. Give few examples of NoSQL databases and their pros and cons.

* MongoDB

    Pros
    * Fast manupulation and fast access.
    * Fast replication.
    * Sharding -- data distribution across multiple machines.
    * Flexible as data does not have to be consistent.
    * Open-source.
    
    Cons
    * Concurrency issues -- no consistency make it unreliable.
    * Resource-hungry due to indexing. 
    * Manual transaction management.

* Redis

    Pros
    * Key-value pairs are simple and fast.
    * Easy data replication.
    * Open-source.
    
    Cons
    * Not suitable for storing large and/or complex data.
    * Performance suffers from persistency snapshots and memory fragmentation.
    
* Cassandra

    Pros
    * Data replication ensures reliable access.
    * Column-oriented data model.
    * Tunable consistency can be eventual or strong.
    * Scalable and reliable.
    * Robust peer-to-peer architecture.
    * Open-source.
    
    Cons
    * Not suitable for storing large and/or complex data.
    * Performance suffers from persistency snapshots and memory fragmentation.