# MemoryLocality

A small example program to demonstrate memory locality.

![image](https://github.com/user-attachments/assets/13cdad7b-3c89-4ec6-9235-0b5aab75bb42)*Times in ms*

![image](https://github.com/user-attachments/assets/93a41e69-3597-4b12-aefa-385ecbe7ea7e)

```
10,000 values
Array: 0ms
List: 0ms
10,000 values and 0 extra columns in the datatable
DataTable: 2ms
10,000 values and 10 extra columns in the datatable
DataTable: 4ms
10,000 values and 100 extra columns in the datatable
DataTable: 27ms

100,000 values
Array: 0ms
List: 0ms
100,000 values and 0 extra columns in the datatable
DataTable: 13ms
100,000 values and 10 extra columns in the datatable
DataTable: 25ms
100,000 values and 100 extra columns in the datatable
DataTable: 174ms

1,000,000 values
Array: 1ms
List: 1ms
1,000,000 values and 0 extra columns in the datatable
DataTable: 110ms
1,000,000 values and 10 extra columns in the datatable
DataTable: 239ms
1,000,000 values and 100 extra columns in the datatable
DataTable: 1,713ms

10,000,000 values
Array: 12ms
List: 13ms
10,000,000 values and 0 extra columns in the datatable
DataTable: 981ms
10,000,000 values and 10 extra columns in the datatable
DataTable: 2,433ms
10,000,000 values and 100 extra columns in the datatable
DataTable: 24,657ms
```
