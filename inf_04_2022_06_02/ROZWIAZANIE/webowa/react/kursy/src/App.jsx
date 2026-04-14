import { useState, createRef } from "react";

function App() {
  const [kursy, setKursy] = useState([
    "Programowanie w C#",
    "Angular dla początkujących",
    "Kurs Django",
  ]);

  const refOsoba = createRef();
  const refKurs = createRef();

  function ZatwierdzFormularz(event) {
    event.preventDefault();
    console.log(refOsoba.current.value);

    if (refKurs.current.value < 1 || refKurs.current.value > kursy.length) {
      console.log("Nieprawidłowy numer kursu");
    } else {
      console.log(kursy[refKurs.current.value - 1]);
    }
  }

  return (
    <>
      <div className="container">
        <div className="col">
          <h2>Liczba kursów: {kursy.length}</h2>

          <ol>
            {kursy.map((kurs, index) => (
              <li key={index}>{kurs}</li>
            ))}
          </ol>

          <form onSubmit={ZatwierdzFormularz}>
            <div className="form-group mb-3">
              <label htmlFor="imieNazwisko">Imię i nazwisko:</label>
              <input
                type="text"
                className="form-control"
                id="imieNazwisko"
                ref={refOsoba}
              />
            </div>

            <div className="form-group mb-3">
              <label htmlFor="numerKursu">Numer kursu:</label>
              <input
                type="number"
                className="form-control"
                id="numerKursu"
                ref={refKurs}
              />
            </div>

            <button type="submit" className="btn btn-primary">
              Zapisz do kursu
            </button>
          </form>
        </div>
      </div>
    </>
  );
}

export default App;
