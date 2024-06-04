var editor;

require(["./vs/editor/editor.main"], () => {
editor = monaco.editor.create(document.getElementById("container"), {
    value: '',
    language: "lua",
    theme: "vs-dark",
    automaticLayout: true
});
});