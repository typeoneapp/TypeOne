import { useEffect, useState } from "react";

const API = import.meta.env.VITE_API_URL;

export default function App() {
    const [status, setStatus] = useState("sprawdzam...");

    useEffect(() => {
        fetch(`${API}/health`)
            .then((r) => r.json())
            .then((t) => setStatus(String(t)))
            .catch(() => setStatus("brak połączenia z API"));
    }, []);

    return (
        <main style= {{ padding: 24 }
}>
    <h1>Team Voting </h1>
        < p > API: { status } </p>
            </main>
  );
}