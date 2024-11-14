// site.js

// Function to switch theme and save preference
function switchTheme() {
    const themeBtnIcon = document.getElementById('themeIcn');

    if (document.documentElement.getAttribute('data-bs-theme') === 'dark') {
        document.documentElement.setAttribute('data-bs-theme', 'light');
        themeBtnIcon.classList.remove('fa-sun');
        themeBtnIcon.classList.add('fa-moon');
        localStorage.setItem('theme', 'light');
    } else {
        document.documentElement.setAttribute('data-bs-theme', 'dark');
        themeBtnIcon.classList.remove('fa-moon');
        themeBtnIcon.classList.add('fa-sun');
        localStorage.setItem('theme', 'dark');
    }
}

// Function to load theme preference on page load
function loadTheme() {
    const savedTheme = localStorage.getItem('theme') || 'light';
    const themeBtnIcon = document.getElementById('themeIcn');

    document.documentElement.setAttribute('data-bs-theme', savedTheme);
    if (savedTheme === 'dark') {
        themeBtnIcon.classList.remove('fa-moon');
        themeBtnIcon.classList.add('fa-sun');
    } else {
        themeBtnIcon.classList.remove('fa-sun');
        themeBtnIcon.classList.add('fa-moon');
    }
}

// Function to initialize theme early
function initTheme() {
    const savedTheme = localStorage.getItem('theme') || 'light';
    document.documentElement.setAttribute('data-bs-theme', savedTheme);
    return savedTheme;
}

// Initialize theme early
initTheme();

// Load theme on page load
document.addEventListener('DOMContentLoaded', loadTheme);
