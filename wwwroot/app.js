

$.get('/api/menu').then(menu =>{
    menu.forEach(item =>{
        document.getElementById("menu").innerHTML += item.name + " - $" + item.price +"<br>"
    })
})