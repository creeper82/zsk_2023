<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\ArrayController;
use App\Http\Controllers\UserFormController;

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

Route::middleware([
    'auth:sanctum',
    config('jetstream.auth_session'),
    'verified',
])->group(function () {
    Route::get('/dashboard', function () {
        return view('dashboard');
    })->name('dashboard');
});
 
Route::get("sample_user", [ArrayController::class, "ShowArray"]);
Route::get("user_form", function() {
    return view("forms.user_form");
});
Route::redirect("", "user_form");

Route::get("UserFormController", [UserFormController::class, "ShowUser"]);