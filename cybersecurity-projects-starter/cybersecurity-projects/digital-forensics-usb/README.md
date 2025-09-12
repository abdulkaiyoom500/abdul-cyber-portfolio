# Digital Forensics – Workstation & USB (Case Study)

This case study documents a full digital-forensics workflow on a workstation and a connected USB memory stick. It includes **search & seizure**, **forensic imaging with integrity verification (MD5/SHA-256)**, **artifact analysis in Autopsy**, and **legally defensible reporting** with a maintained **chain of custody**. :contentReference[oaicite:0]{index=0}

---

## 🎯 Scenario & Objectives

**Scenario.** A staff workstation was found with a USB device inserted. The investigation aimed to determine whether company policy was violated by creating, storing, or distributing prohibited image content (described in the brief as “geometric shapes”). :contentReference[oaicite:1]{index=1}

**Objectives.**
- Preserve evidence (volatile + non-volatile) in a forensically sound manner.
- Acquire images using a **write-blocker** and verify integrity with **MD5/SHA-256**. :contentReference[oaicite:2]{index=2}
- Analyze the memory stick and derived artifacts in **Autopsy** to identify suspicious files, parent-child relationships, and timelines. :contentReference[oaicite:3]{index=3}
- Produce a legally defensible report and maintain a **chain-of-custody** record. :contentReference[oaicite:4]{index=4}

---

## 🧩 Tools & Environment

- **FTK Imager** — acquisition of forensic images, hash verification. :contentReference[oaicite:5]{index=5}  
- **Autopsy** — examination of images, recovery of deleted/hidden files, metadata/timeline analysis. :contentReference[oaicite:6]{index=6}  
- **Write-blocker**, evidence bags with tamper-evident seals, scene photography, detailed logbook. :contentReference[oaicite:7]{index=7}

---

## 🧪 Methodology (High-Level)

1. **Search & Seizure**
   - Secured the scene; documented workstation + USB with photos.  
   - Preserved volatile data first; then proceeded to controlled shutdown and evidence bagging. :contentReference[oaicite:8]{index=8}

2. **Image Acquisition**
   - Used **FTK Imager** via a **write-blocker** to create bit-for-bit images (including unallocated space).  
   - Generated **MD5 and SHA-256** pre/post hashes—no discrepancies observed. :contentReference[oaicite:9]{index=9}

3. **Analysis (Autopsy)**
   - Enumerated and carved artifacts, including deleted/hidden files.  
   - Flagged suspicious items (extension/MIME mismatch, embedded/archived content).  
   - Reconstructed **parent-child** relationships (archives → embedded images). :contentReference[oaicite:10]{index=10}

4. **Reporting**
   - Built an evidence-summary table with metadata and hashes; maintained a **chain-of-custody** and a **record of actions**. :contentReference[oaicite:11]{index=11}

---

## 🔎 Key Findings (Examples)

- **file1.jpg** — standalone image with prohibited content. :contentReference[oaicite:12]{index=12}  
- **file10.tar.gz → file10.tar → file10.jpg** — archive containing prohibited images (derived chain). :contentReference[oaicite:13]{index=13}  
- **file9.boo → file9.jpg** — compressed container with relevant image. :contentReference[oaicite:14]{index=14}  
- **file12.doc → image_0.jpg** — embedded image inside a document (concealment attempt). :contentReference[oaicite:15]{index=15}  
- **file13.dll:here** — misleading extension; actually an image with prohibited content. :contentReference[oaicite:16]{index=16}  
- **file2.dat** — anomalous extension/MIME mismatch; flagged for review. :contentReference[oaicite:17]{index=17}  

> These items, along with metadata, indicate creation/storage during working hours and attempts to compress/obfuscate content. :contentReference[oaicite:18]{index=18}

---

## 🕒 Timeline Highlights

- Example: creation dates around **2004-06-10** for `file1.jpg` and `file10.tar.gz`; other artifacts modified during business hours—supports usage on the corporate system and intent. :contentReference[oaicite:19]{index=19}

---

## 📋 Evidence Summary (Excerpt)

| Artifact                                    | Location/Source                                       | Type     | Notable Metadata / Hash                              | Relevance |
|---|---|---|---|---|
| `file10.tar.gz → file10.tar → file10.jpg`   | `/img_cwk1.dd/archive/...`                            | Archive/Image | e.g., MD5 `c476a66c…` (from report table)           | Prohibited content within nested archive. :contentReference[oaicite:20]{index=20} |
| `file13.dll:here`                           | `/img_cwk1.dd/misc/...`                               | Image    | MD5 `9b787e63…`                                      | Misleading extension; prohibited content. :contentReference[oaicite:21]{index=21} |
| `file2.dat`                                 | `/img_cwk1.dd/alloc/file2.dat`                        | Anomalous| MD5 `de5d8315…`                                      | Extension/MIME mismatch; suspicious. :contentReference[oaicite:22]{index=22} |
| `file12.doc → image_0.jpg`                  | `/misc/file12.doc`                                     | Doc/Img | Embedded image artifact                              | Concealment of prohibited content. :contentReference[oaicite:23]{index=23} |

> Full metadata/hashes are recorded in the report’s tables and logs. :contentReference[oaicite:24]{index=24}

---

## 🧭 Chain of Custody & Record of Actions

- Seizure, transport, imaging, and storage events logged with **timestamps**, **handlers**, and **locations**; **MD5/SHA-256** values recorded to prove integrity. :contentReference[oaicite:25]{index=25}

---

## 🧑‍🍳 How to Reproduce (Skills Demonstration)

> This section guides reviewers through your *process* (no sensitive data).

1. Document a hypothetical scene and list evidence items.  
2. Acquire a **forensic image** (write-blocked) with **FTK Imager**; generate **MD5/SHA-256**.  
3. Import to **Autopsy**; run ingest modules; search for:
   - Suspicious extensions/MIME mismatches (e.g., `.dll` that’s actually an image).
   - **Embedded content** inside office docs.
   - **Archives** with nested items; build **parent-child** mapping.  
4. Build a **timeline** (created/modified/accessed); highlight business-hours activity.  
5. Produce a **summary table**, **chain-of-custody**, and **final conclusions**.

---

## 📂 Repository Structure
