

function rollDice(){
    var pos = 0;
    id = setInterval(frame, 30)
    var value = document.querySelector(".dice-value").value
    function frame(){
        if (pos == 100) {
            clearInterval(id);
            document.querySelector(".dnd-dice").classList.remove("dice-img")
            document.querySelector(".dice-roll-output").innerHTML = Math.floor(Math.random() * value) + 1
        } else {
            pos++;
            document.querySelector(".dnd-dice").classList.add("dice-img")
            document.querySelector(".dice-roll-output").innerHTML = Math.floor(Math.random() * value) + 1
        }
    }
}