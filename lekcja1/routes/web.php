<?php

use App\Http\Controllers\ProfileController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('/dashboard', function () {
    return view('dashboard');
})->middleware(['auth', 'verified'])->name('dashboard');

Route::get("/helloworld", function() { return view('helloworld');});

// wywolanie view helloworld z parametrami
Route::get("/helloworld2", function() {
    return (view('helloworld', ["name" => "Milosz", "surname" => "wyyyyyypychylo"]) );
});

Route::redirect("/", "/helloworld");

Route::get('/status', function() {
    return "Status: " . app("Illuminate\Http\Response") -> status();
});

// parametr w url
Route::get("/pages/{page}", function($page) {
    $info = [
        "about" => "Informacja o stronie",
        "contact" => "contact@o2.pl",
        "home" => "Strona domowa",
    ];
    return $info[$page];
});

Route::get("/address/{city}", function(string $city) {
    echo<<<ADDRESS
        Twój adres: <br>
        $city
    ADDRESS;
});

Route::get("/address/{city}/{street}", function(string $city, string $street) {
    echo<<<ADDRESS
        Twój adres: <br>
        $city, ul. $street
    ADDRESS;
});

Route::get("/address2/{city}/{street}/{zipCode}", function(string $city, string $street, int $zipCode) {
    $zipCode = substr($zipCode, 0, 2) . "-" . substr($zipCode, 2);
    echo<<<ADDRESS
        Twój adres: <br>
        $city, ul. $street <br>
        Kod pocztowy: $zipCode
        <hr>
    ADDRESS;
});

Route::get("/address3/{city}/{street}/{zipCode?}", function(string $city, string $street, int $zipCode = null) {
    if (!is_null($zipCode)) $zipCode = substr($zipCode, 0, 2) . "-" . substr($zipCode, 2);
    else $zipCode = "Brak danych";
    

    echo<<<ADDRESS
        Twój adres: <br>
        $city, ul. $street <br>
        Kod pocztowy: $zipCode
        <hr>
    ADDRESS;
}) -> name("Address");

Route::redirect("/adres/{city}/{street}/{zipCode?}", "/address3/{city}/{street}/{zipCode?}");

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
    Route::delete('/profile', [ProfileController::class, 'destroy'])->name('profile.destroy');
});

require __DIR__.'/auth.php';
