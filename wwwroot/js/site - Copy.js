import * as THREE from 'three';
import { STLLoader } from 'sTLLoader';

var scene = new THREE.Scene();
var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
camera.position.z = 5;
var renderer = new THREE.WebGLRenderer();
renderer.setSize(window.innerWidth, window.innerHeight);
document.body.appendChild(renderer.domElement);

var mesh; // Declare mesh variable in outer scope

var loader = new STLLoader();
loader.load('/Stlimage/Wolf_One_stl.stl', function (geometry) {
    var material = new THREE.MeshNormalMaterial();
    mesh = new THREE.Mesh(geometry, material); // Assign mesh object
    scene.add(mesh);
});

var ambientLight = new THREE.AmbientLight(0xffffff, 0.5);
scene.add(ambientLight);

var directionalLight = new THREE.DirectionalLight(0xffffff, 0.5);
directionalLight.position.set(0, 1, 0);
scene.add(directionalLight);

function render() {
    requestAnimationFrame(render);
    renderer.render(scene, camera);
}
render();

var mouseDown = false, mouseX = 0, mouseY = 0;
document.addEventListener('mousedown', function (event) {
    mouseDown = true;
    mouseX = event.clientX;
    mouseY = event.clientY;
});
document.addEventListener('mouseup', function () {
    mouseDown = false;
});
document.addEventListener('mousemove', function (event) {
    if (!mouseDown || !mesh) return; // Check if mesh is defined
    var deltaX = event.clientX - mouseX,
        deltaY = event.clientY - mouseY;
    mouseX = event.clientX;
    mouseY = event.clientY;
    var rotationX = mesh.rotation.x + deltaY * 0.01,
        rotationY = mesh.rotation.y + deltaX * 0.01;
    mesh.rotation.x = rotationX;
    mesh.rotation.y = rotationY;
});
