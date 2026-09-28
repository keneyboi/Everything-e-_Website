/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.razor",
    "./**/*.html",
    "./**/*.cshtml",
    "!./node_modules/**",
    "!./bin/**",
    "!./obj/**"
  ],
  theme: {
    extend: {
      colors: {
        'brand-orange': '#ff8800',
        'brand-orangeDark': '#e67e00',
        'brand-dark': '#141414',
        'brand-gray': '#f5f5f5',
      },
      fontFamily: {
        pixel: ["Doto", "monospace"],
        sans: [
          "Inter",
          "-apple-system",
          "BlinkMacSystemFont",
          "Segoe UI",
          "Roboto",
          "Helvetica Neue",
          "Arial",
          "sans-serif",
        ],
      },
    },
  },
  plugins: [],
};