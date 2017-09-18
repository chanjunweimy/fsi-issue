module Fsi

open MathNet.Numerics.LinearAlgebra;

let MatrixToRowSeqSeq matrix1 = 
    Matrix.toRowArrays matrix1
    |> Array.map Array.toSeq
    |> Array.toSeq