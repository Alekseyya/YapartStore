'use strict';

let liArray = document.getElementById("select-car__enum").children;
let tmpList = ["Audi", "Acura", "BMW", "Caddilac", "Changan", "Cherry", "Citroen", "Chevrolet"];

let popularList = ["Audi", "Acura", "BMW", "Caddilac", "Changan"];

let createClassName = "select-car__selected";
let appendClassName = "select-car__list";

function AddEventListner() {
    //for char cars
    for (var i = 0; i < liArray.length; i++) {

        liArray[i].addEventListener('click', function (event) {
            CreateCarList(event);
            ActiveSelectChar(event.target);
        });    
    } 
    //view all or popular
    document.querySelector('.select-car__buttons').addEventListener('click',
        function(event) {
            ShowPopulerOrNotCars(event.target);
        });
}

function ShowPopularCars() {
    CreateDivCarList(createClassName, appendClassName, popularList);
}

function ShowPopulerOrNotCars(span) {
    if (span.className === "select-car__show-all") {
        ResetSelection();
        span.style = "display: none";
        CreateDivCarList(createClassName, appendClassName, tmpList);
        document.querySelector('.select-car__show-popular').style = "display: initial";
    } else {
        span.style = "display: none";
        ResetSelection();
        CreateDivCarList(createClassName, appendClassName, popularList);
        document.querySelector('.select-car__show-all').style = "display: initial";
    }
}

function DeleteSelectedList(className){
    let remoteDiv = document.getElementsByClassName(className)[0];
    if (remoteDiv) {
        remoteDiv.parentNode.removeChild(remoteDiv);
        return true;
    }
    return false;
}


function CreateCarList(event) {
    let charCar = event.target.innerHTML;
    if (tmpList.length != 0) {
        if (event.target.id === "all-cars") {
            CreateDivCarList(createClassName, appendClassName, tmpList);
        } else {
            let carsNameArray = FilterCarsList(charCar);
            CreateDivCarList(createClassName, appendClassName, carsNameArray);
        }
    }
}

function ActiveSelectChar(tag) {
    ResetSelection();
    tag.className = "active";
}

function ResetSelection() {
    let liArray = document.querySelectorAll('#select-car__enum li:not(.all-cars)');
    for (let li of liArray) {
        li.className = "";
    }
}

function CreateDivCarList(className, appendClassName, carsArray) {
    DeleteSelectedList("select-car__selected");

    let divCarsList = document.createElement("div");
    divCarsList.className = className;
    document.getElementsByClassName(appendClassName)[0].appendChild(divCarsList);

    for (let carName of carsArray) {
        let aTag = document.createElement("a");
        aTag.style = "display:inline";
        aTag.innerHTML = carName;
        aTag.href = "#";
        divCarsList.appendChild(aTag);
    }
}

function FilterCarsList(charCar){
    let carsNameArray = [];
        for (let carName of tmpList) {
            if (carName.charAt(0) === charCar) {
                carsNameArray.push(carName);
            }
        }
    return carsNameArray;
}



(function() {
    AddEventListner();
    ShowPopularCars();
}());




// (function () {
//     let liArray = document.getElementById("temp").children;
//     console.log(liArray.length);
//     let textArray = [];
//     for (let index = 0; index < liArray.length; index++) {
//         textArray.push(liArray[index].innerHTML);        
//     }
//     console.log(textArray);

//     let parts = document.getElementsByClassName("parts")[0].children;
//     for (let part of parts) {
//        if(part.innerHTML.charAt(0) === "A"){
//            console.log(part.innerHTML);
//        }      
//     }

// }());
