/** @type {import('tailwindcss').Config} */
module.exports = {
  // IMPORTANT: this must cover every folder that contains .razor files,
  // or Tailwind will "tree-shake" away classes you used and your new
  // markup will render unstyled (another common cause of "it looks like
  // nothing changed").
  content: [
    "./Components/**/*.razor",
    "./Components/**/*.razor.cs",
    "./wwwroot/**/*.html",
  ],
  theme: {
    extend: {
      colors: {
        brand: {
          orange: "#ff8800",
          orangeDark: "#e67e00",
          dark: "#141414",
          gray: "#f5f5f5",
        },
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
