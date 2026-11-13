# Documents vs Tables

## 1. Documents (Non-relational Database – NoSQL)

1. Has a flexible schema, meaning documents can have different structures.
2. Stores data in JSON-like documents (BSON in MongoDB).
3. Can store nested documents and arrays.
4. Example: MongoDB.

**Example – MongoDB**

A student document:

{
  "id": 1,
  "name": "Rahul",
  "age": 22
}


## 2. Tables (Relational Database – SQL)

1. Has a structured schema that defines the table's columns and data types.
2. Stores data in rows and columns.
3. Relationships are established using primary keys and foreign keys.
4. Examples: PostgreSQL, MySQL.

**Example – PostgreSQL**

A students table:

| ID | Name  | Age |
-------------------
| 1  | Rahul | 22  |