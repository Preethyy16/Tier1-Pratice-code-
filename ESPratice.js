import { greetStudent,ISPrimeNum } from "./Helper.js";
//  let and const
let studentName = "Joy";
const qualification = "Masters";
console.log(studentName);
console.log(qualification);

//  Template literals
console.log(`Hello ${studentName}, you are studying ${qualification}.`);

// 5. Destructuring
const studentMarks = {
    name:"ALex",
    CGPA:8.9,
    course: "MCA"
};
const { name, CGPA, course } = studentMarks;

console.log(name);
console.log(CGPA);
console.log(course);

// 6. Spread operator
const numbers1 = [1, 2, 3];
const numbers2 = [4, 5, 6];
const combinedNumbers = [...numbers1, ...numbers2];
console.log(combinedNumbers);

const operator1 = [1, 2, 3];
const operator2 = [4, 5, 6];

const addNumbers = [...operator1, ...operator2];
let total = 0;
for (let i = 0; i < addNumbers.length; i++) {
    total = total + addNumbers[i];
}
console.log(total);

// Module import usage
console.log(greetStudent(studentName));
console.log(ISPrimeNum(7));
console.log(ISPrimeNum(10));

