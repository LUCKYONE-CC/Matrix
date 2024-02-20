# Matrix

## How it works

### Create Matrix-Structure
The constructor takes `int rows` and `int columns`
```cs
MatrixStructure<int> matrix = new MatrixStructure<int>(2, 2);
```

### Multiply matrix with integers
```cs
var matrix = new MatrixStructure<int>(2, 2);

var newMatrix = matrix * 6;
```

### Multiply matrix with other matrix
```cs
MatrixStructure<int> matrix = new MatrixStructure<int>(2, 2);
matrix[0, 0] = 2;
matrix[0, 1] = 2;
matrix[1, 0] = 2;
matrix[1, 1] = 2;

MatrixStructure<int> matrix2 = new MatrixStructure<int>(2, 2);
matrix2[0, 0] = 2;
matrix2[0, 1] = 2;
matrix2[1, 0] = 2;
matrix2[1, 1] = 2;

MatrixStructure<int> result = matrix * matrix2;
```

### Print matrix
```cs
MatrixStructure<int> matrix = new MatrixStructure<int>(2, 2);
matrix[0, 0] = 2;
matrix[0, 1] = 2;
matrix[1, 0] = 2;
matrix[1, 1] = 2;

matrix.PrintMatrix();
```

Output: 
```
2 2 
2 2
```
