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

Route::redirect("/", "/status");

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

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
    Route::delete('/profile', [ProfileController::class, 'destroy'])->name('profile.destroy');
});

require __DIR__.'/auth.php';
