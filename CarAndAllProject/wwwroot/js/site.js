// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function switchTheme() {
    const themeBtnIcon = document.getElementById('themeIcn');

    if (document.documentElement.getAttribute('data-bs-theme') == 'dark') {
        document.documentElement.setAttribute('data-bs-theme', 'light')
        themeBtnIcon.classList.remove('fa-sun');
        themeBtnIcon.classList.add('fa-moon');
    }
    else {
        document.documentElement.setAttribute('data-bs-theme', 'dark')
        themeBtnIcon.classList.remove('fa-moon');
        themeBtnIcon.classList.add('fa-sun');
        //change the class of the button

    }
}


