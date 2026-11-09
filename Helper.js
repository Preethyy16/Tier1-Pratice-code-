
function greetStudent(name) {
    
    return `Hello\n Helper.js is invloked and the Name is: ${name}, welcome to Es6 and TypeScript course!`;
}

//  Arrow function
const ISPrimeNum = (a) => {
    if (a <= 1) {
        return a + " is NOT a prime number";
    }

    for (let i = 2; i < a; i++) {
        if (a % i == 0) {
            return a + " is NOT a prime number";
        }
    }

    return a + " is a prime number";
};

export { greetStudent,ISPrimeNum };


