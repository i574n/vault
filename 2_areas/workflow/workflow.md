---
test1: 1
test2: x
test3: "x"
---

```txt
x
```

x

x [^x]

x [^2]

xx~~xx~~xx~x~x
x :smile: x
x $E=mc^2$ x

$$
E=mc^2
$$

Term 1
: Definition 1
x{--x--}
x{--x-->x--}
::: x
x
:::

- [x] x
- [ ] x

x

[^x]: x
[^2]: x

---
---

```clojure
(def x (-> (promise) (deliver "text")))
@x

;; #'user/x
```

```clojure
(+ 1 2 3)

;; 6
```

```clojure
(zero? 0)

;; true
```

```clojure
(let [x 1 y 2 z 3] (+ x y z))

;; 6
```

```clojure
(println (((fn [f] ((fn [x] (f (fn [v] ((x x) v)))) (fn [x] (f (fn [v] ((x x) v)))))) (fn [g] (fn [name] (str "Hello, " name "!")))) "John Doe"))

;; Hello, John Doe!
```

---
