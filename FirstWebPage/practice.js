var MyName = "Raj";
let details = document.querySelector("#container");
let para = document.createElement("p");
para.textContent=MyName;
details.append(para);

// Function
function AddDetails(name,age,gender) {
    return "Name:" + name +" Age is: "+ age+" Gender: "+ gender ;
}
let detailsList = document.querySelector("#userDetails");
let CreateList = document.createElement("p");
CreateList.textContent=(AddDetails("Joy",30,"male"))
detailsList.append(CreateList);

// Arrays and Filters()
let ArrAge = [10, 20, 35, 43, 50,98,77,13,90,100];

let OddAgeArr = ArrAge.filter ((age) => { 
    return age % 2 !== 0; });
console.log("Arrag before Filtering :"+ArrAge);
console.log("Odd Numbered Age: "+OddAgeArr);
 

// Arrays and map()
let marks = [45, 80, 35, 90, 60];
let  graceMarks= marks.map((mark) => {
    return mark += 2 ;
});

console.log("The Student Marks after adding the grace marks :"+ graceMarks);


//  Objects
let CarsDetails = {
    Model: "kia",
    price: 7000000,
    milage: 12
};
CreateList.textContent = "Car Details: " +
    CarsDetails.Model + " " +
    CarsDetails.price + " " +
    CarsDetails.milage;

detailsList.append(CreateList);
console.log("car details" + CarsDetails.Model,CarsDetails.price,CarsDetails.milage);
