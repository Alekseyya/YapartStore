'use strict';

let liArray = document.getElementById("select-car__enum").children;
let tmpList = ["Audi", "Acura", "BMW", "Caddilac", "Changan", "Cherry", "Citroen", "Chevrolet"];

function AddEventListner(){
    for (var i = 0; i < liArray.length; i++) {

        liArray[i].addEventListener('click', function (event) {
            CreateLinkListCars(event.target.innerHTML, "select-car__list");            
        });    
    }    
}

function DeleteSelectedList(){
    let remoteDiv = document.getElementsByClassName("select-car__selected")[0];
    if (remoteDiv) {
        remoteDiv.parentNode.removeChild(remoteDiv);
        return true;
    }
    return false;
}


function CreateLinkListCars(carName, newClassName) {
    if (tmpList.length != 0) {
        DeleteSelectedList();

        let carsNameArray = FilterCarsList(carName);

        //create div
        let divCarsList = document.createElement("div");
        divCarsList.className = "select-car__selected";
        document.getElementsByClassName(newClassName)[0].appendChild(divCarsList);

        for (let carName of carsNameArray) {
            let aTag = document.createElement("a");
            aTag.style = "display:inline";
            aTag.innerHTML = carName;
            aTag.href = "#";
            divCarsList.appendChild(aTag);
        }
    }
}

function FilterCarsList(carName){
    let carsNameArray = [];
        for (let car of tmpList) {
            if (car.charAt(0) === carName) {
                carsNameArray.push(car);
            }
        }
    return carsNameArray;
}


(function(){
    AddEventListner();       
}())




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
