
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
(range 10)

;; (0 1 2 3 4 5 6 7 8 9)
```

```clojure
(ns ns1) (defn average [& nums] (/ (reduce + nums) (count nums))) [(average 4 11) (average 3.0 72 9.6 33)]

;; [15/2 29.4]
```

```clojure
(println (((fn [f] ((fn [x] (f (fn [v] ((x x) v)))) (fn [x] (f (fn [v] ((x x) v)))))) (fn [g] (fn [name] (str "Hello, " name "!")))) "John Doe"))

;; Hello, John Doe!
```

```clojure
(require '[clojure.set :as s]) (def a-vowels #{\a \e \i \o \u \x \y \z}) (def b-vowels #{\a \e \i \o \u}) [(s/difference a-vowels b-vowels) (s/union a-vowels b-vowels) (s/intersection a-vowels b-vowels)]

;; [#{\x \y \z} #{\a \e \i \o \u \x \y \z} #{\a \e \i \o \u}]
```

```clojure
(def bhaskara (fn [a b c] (if (or (nil? a) (nil? b) (nil? c)) nil (let [delta (- (* b b) (* 4 a c))] (if (< delta 0) nil (list (/ (+ (- b) (Math/sqrt delta)) (* 2 a)) (/ (- (- b) (Math/sqrt delta)) (* 2 a)))))))) (bhaskara 1 -5 6)

;; (3.0 2.0)
```

```clojure
(let [input-1 [0.1 0.2 0.3] input-2 [0.4 0.5 0.6] weights-1 [[0.1 0.2 0.3] [0.4 0.5 0.6] [0.7 0.8 0.9]] biases-1 [0.1 0.2 0.3] weights-2 [[0.1 0.2 0.3] [0.4 0.5 0.6]] biases-2 [0.1 0.2] activation-fn #(mapv #(Math/tanh %) %)] (for [input [input-1 input-2]] (->> input (mapv #(reduce + (map * % %2)) weights-1) (mapv + biases-1) activation-fn (mapv #(reduce + (map * % %2)) weights-2) (mapv + biases-2) activation-fn)))




```

---
---

## generate a greeting using y combinator with clojurescript

< ClojureScript is a dialect of Clojure that compiles to JavaScript, and the Y combinator is a higher-order function used to derive recursion in functional programming languages. Here's a simple greeting function using the Y combinator in ClojureScript:

```clojure
(defn y-combinator [f]
  ((fn [x] (f (fn [v] ((x x) v))))
   (fn [x] (f (fn [v] ((x x) v))))))

(defn greeting-fn [recur-fn]
  (fn [name]
    (str "Hello, " name "!")))

(def y-greeting (y-combinator greeting-fn))

(println (y-greeting "John Doe"))
```

In this example, the y-combinator function takes a function f as its argument, and it is defined using anonymous functions. The greeting-fn function takes a recur-fn parameter, but in this case, we don't actually need recursion to generate a greeting, so it is not used.

Finally, we apply the y-combinator to the greeting-fn to get the y-greeting function, which we can use to greet people. In the example, the function is called with the argument "John Doe", and it will print "Hello, John Doe!".
