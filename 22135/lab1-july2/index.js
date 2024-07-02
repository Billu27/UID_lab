function changeColor(){
    const p = document.getElementById("para1");
    if(p.style.color == "red"){
        p.style.color = "black";
        p.style.fontSize = "27px";
    }
    else{
        p.style.color = "red";
        p.style.fontWeight = "900";
        p.style.fontSize = "21px";
    }
}

function addNewChat(){
    let inputTxbx = document.getElementById("Lchat").value;
    
    const newCh = document.createElement("div");
    newCh.classList.add("chatLeft");
    newCh.classList.add("chat");
    newCh.textContent = inputTxbx;
    document.body.append(newCh);
}

function addNewChatRight(){
    let inputTxbx = document.getElementById("Rchat").value;
    
    const newCh1 = document.createElement("div");
    newCh1.classList.add("chatRight");
    newCh1.classList.add("chat");
    newCh1.textContent = inputTxbx;
    document.body.append(newCh1);
}