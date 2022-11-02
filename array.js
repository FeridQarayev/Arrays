

let numArray =[ 1, 2, 3, 4 ];
console.log("before");
for (i = 0; i < numArray.length; i++)   //// O(N) — Linear Complexity
{
    console.log(numArray[i])
}

console.log("\n\nafter");
for (i = 0; i < numArray.length; i++)   //// O(N) — Linear Complexity
{
    numArray[i] = numArray[i] + 1
    console.log(numArray[i])
}