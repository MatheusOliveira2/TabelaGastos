async function autenticacao(){
    const { value: password } = await Swal.fire({
        title: 'Digite sua Senha',
        input: 'password',
        inputAttributes: {
            maxlength: 99,
            autocapitalize: 'off',
            autocorrect: 'off'
        }
    })

    if (password == "senha dificil@adm") {
        Swal.fire('Senha Correta', '', 'success');
        $.ajax({
            type: "POST",
            url: "/gastos/Home/gerenciarTabelas",
            success: function (data) {
                window.location.replace("/gastos/home/gerenciartabelas");
            }
        })
    }
    else {
        Swal.fire('Senha Incorreta', '', 'error');
    }
    
}
