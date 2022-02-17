
const scene = new THREE.Scene();
const camera = new THREE.PerspectiveCamera( 75, window.innerWidth / window.innerHeight, 0.1, 1000 );
const renderer = new THREE.WebGLRenderer({
    canvas: document.querySelector("#bg")
});
renderer.setPixelRatio( window.devicePixelRatio );
renderer.setSize( window.innerWidth, window.innerHeight );
renderer.setClearColor( 0xe9ecef );
camera.position.setZ(30);

const geometry = new THREE.TorusGeometry( 10, 3, 16, 10 );
const material = new THREE.MeshBasicMaterial( { color: 0xFF6347, wireframe: true} );
const torus = new THREE.Mesh( geometry, material );
scene.add(torus);

let moveX = 0.1;
let moveY = 0.2;

function animate() {
    requestAnimationFrame( animate );

    torus.rotation.x +=  0.01;
    torus.rotation.y +=  0.01;

    torus.position.x += moveX;
    torus.position.y += moveY;

    if(torus.position.x >= 40){
        moveX = -moveX;
    }
    if(torus.position.x <= -40){
        moveX = -moveX;
    }
    if(torus.position.y >= 40){
        moveY = -moveY;
    }
    if(torus.position.y <= -40){
        moveY = -moveY;
    }

    renderer.render( scene, camera );
}

animate();