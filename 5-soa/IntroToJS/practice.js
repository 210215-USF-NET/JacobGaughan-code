var only5And3Result = document.getElementById('only5And3Result')
var invertStringResult = document.getElementById('invertStringResult')
var resultString

function testOnly5And3(){
    let input = document.getElementById('only5And3Input').value
    only5And3Result.innerHTML = only5And3(input)
}

function testInvertString(){
    let input = document.getElementById('invertStringInput').value
    resultString = ''
    invertStringResult.innerHTML = ''
    invertStringResult.innerHTML = invertString(input)
}


function only5And3(number){
    if(number < 0)
    {
        return false
    }
    if(number % 3 === 0){
        return true
    }
    else
    {
        number -= 5
        return only5And3(number)
    }
}

function invertString(str){
    if(str.length === 0)
    {
        return resultString
    }
    else
    {
        if(str.slice(-1) == str.slice(-1).toUpperCase())
        {
            resultString += str.slice(-1).toLowerCase()
        }
        else
        {
            resultString += str.slice(-1).toUpperCase()
        }
        return invertString(str.slice(0, -1))
    }
}