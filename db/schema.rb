# encoding: UTF-8
# This file is auto-generated from the current state of the database. Instead
# of editing this file, please use the migrations feature of Active Record to
# incrementally modify your database, and then regenerate this schema definition.
#
# Note that this schema.rb definition is the authoritative source for your
# database schema. If you need to create the application database on another
# system, you should be using db:schema:load, not running all the migrations
# from scratch. The latter is a flawed and unsustainable approach (the more migrations
# you'll amass, the slower it'll run and the greater likelihood for issues).
#
# It's strongly recommended that you check this file into your version control system.

ActiveRecord::Schema.define(version: 20180415043313) do

  # These are extensions that must be enabled in order to support this database
  enable_extension "plpgsql"

  create_table "active_admin_comments", force: :cascade do |t|
    t.string   "namespace"
    t.text     "body"
    t.string   "resource_id",   null: false
    t.string   "resource_type", null: false
    t.integer  "author_id"
    t.string   "author_type"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "active_admin_comments", ["author_type", "author_id"], name: "index_active_admin_comments_on_author_type_and_author_id", using: :btree
  add_index "active_admin_comments", ["namespace"], name: "index_active_admin_comments_on_namespace", using: :btree
  add_index "active_admin_comments", ["resource_type", "resource_id"], name: "index_active_admin_comments_on_resource_type_and_resource_id", using: :btree

  create_table "admin_users", force: :cascade do |t|
    t.string   "name"
    t.string   "email",                  default: "", null: false
    t.string   "encrypted_password",     default: "", null: false
    t.string   "reset_password_token"
    t.datetime "reset_password_sent_at"
    t.datetime "remember_created_at"
    t.integer  "sign_in_count",          default: 0,  null: false
    t.datetime "current_sign_in_at"
    t.datetime "last_sign_in_at"
    t.inet     "current_sign_in_ip"
    t.inet     "last_sign_in_ip"
    t.integer  "failed_attempts",        default: 0,  null: false
    t.string   "unlock_token"
    t.datetime "locked_at"
    t.datetime "created_at",                          null: false
    t.datetime "updated_at",                          null: false
  end

  add_index "admin_users", ["email"], name: "index_admin_users_on_email", unique: true, using: :btree
  add_index "admin_users", ["reset_password_token"], name: "index_admin_users_on_reset_password_token", unique: true, using: :btree
  add_index "admin_users", ["unlock_token"], name: "index_admin_users_on_unlock_token", unique: true, using: :btree

  create_table "contact_locations", force: :cascade do |t|
    t.integer "contact_id"
    t.string  "longitude"
    t.string  "latitude"
    t.integer "task_id"
  end

  create_table "contacts", force: :cascade do |t|
    t.string  "first_name"
    t.string  "last_name"
    t.string  "email"
    t.string  "phone_number"
    t.string  "follow_me_id"
    t.integer "organization_id"
    t.integer "role_id"
  end

  create_table "delayed_jobs", force: :cascade do |t|
    t.integer  "priority",   default: 0, null: false
    t.integer  "attempts",   default: 0, null: false
    t.text     "handler",                null: false
    t.text     "last_error"
    t.datetime "run_at"
    t.datetime "locked_at"
    t.datetime "failed_at"
    t.string   "locked_by"
    t.string   "queue"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "delayed_jobs", ["priority", "run_at"], name: "delayed_jobs_priority", using: :btree

  create_table "incident_images", force: :cascade do |t|
    t.string "image_title"
    t.text   "image_description"
    t.string "image"
  end

  create_table "incidents", force: :cascade do |t|
    t.string  "incident_name"
    t.integer "subject_id"
    t.text    "briefing"
    t.text    "persons_of_interest",    default: [], array: true
    t.text    "vehicles",               default: [], array: true
    t.text    "images",                 default: [], array: true
    t.text    "additional_information"
  end

  create_table "organization_relations", force: :cascade do |t|
    t.integer "organization_id"
    t.integer "works_with_organization_id"
  end

  create_table "organizations", force: :cascade do |t|
    t.string  "name"
    t.string  "address"
    t.string  "city"
    t.string  "state"
    t.string  "zip"
    t.string  "phone_number"
    t.string  "longitude"
    t.string  "latitude"
    t.integer "point_of_contact"
  end

  create_table "people", force: :cascade do |t|
    t.string  "first_name"
    t.string  "last_name"
    t.date    "date_of_birth"
    t.string  "gender"
    t.string  "height"
    t.string  "weight"
    t.string  "last_known_longitude"
    t.string  "last_known_latitude"
    t.string  "home_address"
    t.string  "home_city"
    t.string  "home_state"
    t.string  "home_zip"
    t.integer "person_designation_id"
    t.integer "person_description_id"
    t.integer "incident_id"
  end

  create_table "person_descriptions", force: :cascade do |t|
    t.integer "person_id"
    t.string  "hair_color"
    t.string  "hair_length"
    t.string  "eye_color"
    t.string  "hat"
    t.string  "top"
    t.string  "bottoms"
    t.string  "shoes"
    t.string  "bags"
    t.text    "additional_information"
  end

  create_table "person_of_interests", force: :cascade do |t|
    t.integer "person_id"
    t.text    "information"
  end

  create_table "post_templates", force: :cascade do |t|
    t.string "template_name"
    t.text   "content"
  end

  create_table "posts", force: :cascade do |t|
  end

  create_table "roles", force: :cascade do |t|
    t.string "name"
  end

  create_table "tasks", force: :cascade do |t|
    t.string  "title"
    t.string  "status"
    t.text    "details"
    t.integer "contact_id"
    t.string  "priority"
  end

  create_table "users", force: :cascade do |t|
    t.string   "name"
    t.string   "email",                  default: "", null: false
    t.string   "encrypted_password",     default: "", null: false
    t.string   "reset_password_token"
    t.datetime "reset_password_sent_at"
    t.datetime "remember_created_at"
    t.integer  "sign_in_count",          default: 0,  null: false
    t.datetime "current_sign_in_at"
    t.datetime "last_sign_in_at"
    t.inet     "current_sign_in_ip"
    t.inet     "last_sign_in_ip"
    t.datetime "created_at",                          null: false
    t.datetime "updated_at",                          null: false
    t.integer  "organization_id"
  end

  add_index "users", ["email"], name: "index_users_on_email", unique: true, using: :btree
  add_index "users", ["reset_password_token"], name: "index_users_on_reset_password_token", unique: true, using: :btree

  create_table "vehicles", force: :cascade do |t|
    t.string  "make"
    t.string  "model"
    t.integer "year"
    t.string  "color"
    t.string  "license_plate"
    t.string  "license_plate_state"
    t.text    "comments"
  end

end
