# 🧱 Decorator Pattern — Product Bundles Example

This project demonstrates the **Decorator Design Pattern** using a realistic product bundling scenario.  
The idea is to allow dynamic addition of features (like wrapping, insurance, discounts) **without modifying the core `Product` class**.

---

## 🎯 Problem

You sell products (e.g., laptops), and sometimes customers want to:

- Add gift wrapping.
- Add insurance.
- Apply discounts.

If we add all possible combinations as subclasses (`WrappedProduct`, `InsuredProduct`, `DiscountedWrappedProduct`, ...), the number of classes will explode.

**❌ Bad Approach:** Too many subclasses.  
**✅ Better Approach:** Use **Decorator Pattern** to "wrap" features dynamically.

---

## 🛠️ Solution (Using Decorator)

We define:

### ✅ `IInvoiceItem` — the base interface:
```csharp
public interface IInvoiceItem
{
    string GetDetails();
    float GetPrice();
}
```

### 🛒 `Product` — the core item:
```csharp
var product = new Product("Laptop", 1000);
```

### 🎁 `WrapBundle` — adds wrapping fee:
```csharp
var wrapped = new WrapBundle(product, 100);
```

### 🛡️ `InsuranceBundle` — adds insurance:
```csharp
var insurance = new InsuranceBundle(wrapped, 100);
```

### 💸 `DiscountBundle` (Optional) — applies percentage discount:
```csharp
var discount = new DiscountBundle(insurance, 0.1f); // 10%
```

---

## 🧪 Sample Output

```csharp
Console.WriteLine(insurance.GetDetails());
Console.WriteLine(insurance.GetPrice());
```

**Output:**
```
Laptop : 1000 + wrap Cost (100) + insurance Cost (100)
1200
```

---

## 🧩 Structure

```
IInvoiceItem
│
├── Product
│
└── BundleDecorator (abstract)
     ├── WrapBundle
     ├── InsuranceBundle
     └── DiscountBundle
```

---

## 🧠 Why Decorator?

- **Open/Closed Principle** — add new features without touching existing code.
- **Flexible composition** — you can add/remove combinations at runtime.
- **Avoids class explosion** — no need for `WrappedAndInsuredAndDiscountedProduct` subclasses.
