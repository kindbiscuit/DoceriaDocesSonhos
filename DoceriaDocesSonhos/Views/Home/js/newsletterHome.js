const inputEnviar = document.getElementById('iptEnviar')

inputEnviar.addEventListener('click', (event) => {
    event.preventDefault()

    const nome = document.getElementById('nome')
    const email = document.getElementById('email')
    const enviar = document.getElementById('inputEnviar')

    if (nome.value == "") {
        nome.classList.add('erroInput')
    } else {
        nome.classList.remove('erroInput')
    }

    if (email.value.indexOf('@') == -1 || email.value.indexOf('.') == -1 || email.value.indexOf('.') - email.value.indexOf('@') == 1) {
        email.classList.add('erroInput')
    } else {
        email.classList.remove('erroInput')
    }
})