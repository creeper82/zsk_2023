<style>
    body {
        background-color: black;
        color: white;
    }
</style>

<div>
    <h3>Dane użytkownika</h3>
    <p>Podaj te śmieszne dane</p>

    @if($errors->any())
        <p>Błędy:</p>
        <ul>
            @foreach($errors->all() as $error)
                <li>{{$error}}</li>
            @endforeach
        </ul>
    @endif

    <form action="UserFormController" method="GET">
        <input type="text" name="firstName" placeholder="Podaj imię" autofocus> <br>
        @error("firstName") <p>{{$message}}</p> @enderror
        
        <input type="text" name="lastName" placeholder="Podaj nazwisko"> <br>
        @error("lastName") <p>{{$message}}</p> @enderror
        
        <input type="text" name="city" placeholder="Podaj miasto"> <br> 
        @error("city") <p>{{$message}}</p> @enderror
        
        <input type="text" name="hobbies" placeholder="Podaj hobby po przecinku"> <br>
        @error("hobbies") <p>{{$message}}</p> @enderror
        
        <input type="submit" value="Zatwierdź dane">
    </form>
</div>
