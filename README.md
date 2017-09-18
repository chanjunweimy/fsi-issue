![image](https://user-images.githubusercontent.com/7464833/30470996-95a82432-9a29-11e7-850e-a7fa051945b9.png)

Issue [#539](https://github.com/ionide/ionide-vscode-fsharp/issues/539) from [ionide-vscode-fsharp](https://github.com/ionide/ionide-vscode-fsharp)

Exact Steps:
1. Open a fs file which uses "Matrix" reference from MathNet.Numerics
2. Run FSI Start
3. Send References from project
4. open MathNet.Numerics.LinearAlgebra;
5. Run a function that uses "Matrix"

Expected: Showing something related to the Matrix
Actual: Failed as it requires reference from MathNet.Numerics