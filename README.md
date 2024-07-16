# MemoryLocality

A small example program to demonstrate memory locality. Emphasises inefficiency of datatable.

```
10,000 values and 0 extra columns in the datatable
Array: 0ms
List: 0ms
DataTable: 3ms


10,000 values and 10 extra columns in the datatable
Array: 0ms
List: 0ms
DataTable: 7ms


10,000 values and 100 extra columns in the datatable
Array: 0ms
List: 0ms
DataTable: 49ms


1,000,000 values and 0 extra columns in the datatable
Array: 6ms
List: 9ms
DataTable: 210ms


1,000,000 values and 10 extra columns in the datatable
Array: 5ms
List: 8ms
DataTable: 469ms


1,000,000 values and 100 extra columns in the datatable
Array: 4ms
List: 8ms
DataTable: 3,886ms


10,000,000 values and 0 extra columns in the datatable
Array: 45ms
List: 79ms
DataTable: 2,063ms


10,000,000 values and 10 extra columns in the datatable
Array: 46ms
List: 81ms
DataTable: 5,021ms


10,000,000 values and 100 extra columns in the datatable
Array: 45ms
List: 82ms
DataTable: 18,762ms
```

<img width="816" alt="image" src="https://github.com/user-attachments/assets/a2b3cfab-6dcb-4825-982b-820878a438ac">


