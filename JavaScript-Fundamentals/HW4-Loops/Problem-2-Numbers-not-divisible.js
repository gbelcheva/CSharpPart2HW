//Problem 2. Numbers not divisible
//
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var N = 100,
    count = 1;


while (count <= N) {
    if (count % 21){
        console.log(count);
    }
    count += 1;
}