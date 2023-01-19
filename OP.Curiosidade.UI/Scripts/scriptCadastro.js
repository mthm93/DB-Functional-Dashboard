/* Preenchimento do Cadastro */

function cadastro() {
    let nome = document.getElementById('nome');

    if (nome.value.length !== 0) {
        window.open("https://mthm93.github.io/OP-Curiosidade/dashboard/relatorios.html", "_self");;
    } else {
        alertaCadastro.innerHTML = 'Preencha o campo nome.';
        alertaCadastro.style.textAlign = "center";
        alertaCadastro.style.color = "red";
        alertaCadastro.style.fontSize = "12px";
    }
}