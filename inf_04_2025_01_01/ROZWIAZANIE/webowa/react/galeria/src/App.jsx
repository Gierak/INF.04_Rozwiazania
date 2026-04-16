import { useState } from "react";
import dane from "./dane";
import "./App.css";

function App() {
  const [dane1, setDane1] = useState(dane);

  const [kwiaty, setKwiaty] = useState(true);
  const [zwierzeta, setZwierzeta] = useState(true);
  const [samochody, setSamochody] = useState(true);

  function Pobierz(id) {
    setDane1(
      dane1.map((element) => {
        if (element.id == id) {
          return { ...element, downloads: element.downloads + 1 };
        } else {
          return element;
        }
      }),
    );
  }

  function zmianaKwiaty(e) {
    setKwiaty(e.target.checked);
  }

  function zmianaZwierzeta(e) {
    setZwierzeta(e.target.checked);
  }

  function zmianaSamochody(e) {
    setSamochody(e.target.checked);
  }

  return (
    <main className="mx-3 my-2">
      <h1>Kategorie zdjęć</h1>

      <div className="d-flex gap-4">
        <div className="form-check form-switch">
          <input
            className="form-check-input"
            type="checkbox"
            id="kwiaty"
            checked={kwiaty}
            onChange={zmianaKwiaty}
          />
          <label className="form-check-label" htmlFor="kwiaty">
            Kwiaty
          </label>
        </div>

        <div className="form-check form-switch">
          <input
            className="form-check-input"
            type="checkbox"
            id="zwierzeta"
            checked={zwierzeta}
            onChange={zmianaZwierzeta}
          />
          <label className="form-check-label" htmlFor="zwierzeta">
            Zwierzęta
          </label>
        </div>

        <div className="form-check form-switch">
          <input
            className="form-check-input"
            type="checkbox"
            id="samochody"
            checked={samochody}
            onChange={zmianaSamochody}
          />
          <label className="form-check-label" htmlFor="samochody">
            Samochody
          </label>
        </div>
      </div>

      <div className="d-flex flex-wrap justify-content-center">
        {dane1
          .filter((element) => {
            return (
              (kwiaty && element.category == 1) ||
              (zwierzeta && element.category == 2) ||
              (samochody && element.category == 3)
            );
          })
          .map((element) => (
            <div className="blokZdjec" key={element.id}>
              <img src={"assets/" + element.filename} alt={element.alt} />
              <h4>Pobrań: {element.downloads}</h4>
              <button
                className="btn btn-success"
                onClick={() => {
                  Pobierz(element.id);
                }}
              >
                Pobierz
              </button>
            </div>
          ))}
      </div>
    </main>
  );
}

export default App;
